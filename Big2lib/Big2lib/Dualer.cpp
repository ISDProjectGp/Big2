#include "stdafx.h"
#include <stdio.h>     
#include <time.h>
#include "Deck.h"
#include "Dualer.h"


using namespace DealerCode;
using namespace DeckCode;
using namespace CardCode;
using namespace HandCode;

	Dealer::Dealer(Deck* deck)
	{
		srand(time(NULL));                       // Generate the random seeds //
		_deck = deck;
		_deck->createDeck();                     //Init the deck // 
	}

	void Dealer::deal(Hand& hand)
	{
		if (_deck != nullptr)
		{
			hand.add(_deck->getCard());                //Add the card for hand // 
		}
	}

	void Dealer::swap(Card* cardA, Card* cardB)
	{
		Card temp = *cardA;
		*cardA = *cardB;
		*cardB = temp;
	}

	Dealer::Dealer()
	{
	}

	Dealer::~Dealer()
	{
		if (_deck != nullptr)                                // Check for nullptr //
		{
			_deck->~Deck();                                  // Delete the deck // 
		}
	}

	void Dealer::shuffle()
	{
		if (_deck != nullptr)
		{
			for (int i = 0; i < 52; i++)
			{
				int randomNum = rand() % 52;                           // Generate a random number //
				swap(_deck->getCard(i), _deck->getCard(randomNum));    // Swap the card with another card with random poistion  // 
			}
		}
	}


