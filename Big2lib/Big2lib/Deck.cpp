#include "stdafx.h"
#include "Deck.h"

using namespace DeckCode;
using namespace CardCode;

	Deck::Deck()
	{
		_cards = new Card[DECK_CAPACITY];
		_numOfCard = DECK_CAPACITY;
	}

	Card* Deck::getCard(int index) const       // The dualer will use this function for swap the card     //
	{
		if (index<DECK_CAPACITY && index>-1)
		{
			return _cards + index;               // return the card with accociated index    //
		}
		return nullptr;
	}

	inline int Deck::getNoCard() const
	{
		return _numOfCard;
	}

	Card* Deck::getCard()
	{                                         // The dualer will use this function for dual the card                     //
		if (_numOfCard != 0)
		{
			_numOfCard -= 1;                  // If a card is dualed , the number of card in the deck will decrease by 1 //                       
			return _cards + _numOfCard;       // The pointer of the card with largest index at that time                 // 
		}
		return nullptr;
	}

	void Deck::createDeck()
	{
		_numOfCard = DECK_CAPACITY;
		char suit[4] = { 'D','C','H','S' };                   // Declare the char to store suit      //
		for (int i = 0; i < DECK_CAPACITY; i++)               // Initialize the deck                 // 
		{
			if (i < 8)                                        // Setting the weight for Ace and Two  //
			{
				_cards[i].setWeight(i + 44);
			}
			else                                              // Setting the weight for others       //
			{
				_cards[i].setWeight(i - 8);
			}
			_cards[i].setValue(i / 4 + 1);                    // Setting the value                   //
			_cards[i].setSuit(suit[i % 4]);                   // Setting the suit                    //
		}
	}

	void Deck::clear()
	{
		delete[] _cards;
		_cards = new Card[DECK_CAPACITY];
		_numOfCard = DECK_CAPACITY;
	}

	Deck::~Deck()
	{
		delete[] _cards;
	}

