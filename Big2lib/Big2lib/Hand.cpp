#include "stdafx.h"
#include <vector>
#include <iostream>
#include "Hand.h"

using namespace std;

using namespace HandCode;

	Hand::Hand()
	{
		_isContainDiamondThree = false;
		_isOneCardinHand = false;
	}

	inline int Hand::getNoCard() const
	{
		return _cards.size();              // return the size of the container // 
	}

	bool Hand::isContainDiamondThree() const
	{
		return _isContainDiamondThree;    
	}

	Card* Hand::getCards(int index) const
	{
		// if the index is valid // 
		if (index<getNoCard() && index>-1)
		{
			return _cards[index];       // return the address of the cards in hand // 
		}
		return nullptr;
	}



	bool Hand::add(Card* card)
	{
		if (_cards.size()<14)           // If the number of cards in hand is samller than 14 //
		{
			_cards.push_back(card);     // Add the pointer of cards to the container// 

			if (card->getValue() == 3 && card->getSuit() == 'D')  // if the card is Diamond Three ///
			{
				_isContainDiamondThree = true;
			}
			return true;                // Successfully add the card to the container  // 
		}

		return false;                   // Fail to add the card to the container // 
	}



	Card* Hand::release(int value, char suit)
	{
		for (int i = 0; i < _cards.size(); i++)
		{
			if (_cards[i]->getValue() == value && _cards[i]->getSuit() == suit)      // If the card with value and suit is in the container //  
			{
				Card* temp = _cards[i];
				_cards.erase(_cards.begin() + i);                                   // Remove the card from the container //  
				return temp;                                                	  // Return the pointer the cards that remove from from the container //  
			}
		}
		return nullptr;                                                          // Return nullptr , if the card with value and suit is not in the container //  
	}

	void Hand::clear()
	{
		_isContainDiamondThree = false;
		_isOneCardinHand = false;
		_cards.clear();                    // Remove all the pointer of cards in container // 
	}

	void Hand::sortCards()
	{
		for (int i = 0; i < _cards.size() - 1; i++)
		{
			for (int j = 0; j < _cards.size() - 1 - i; j++)
			{
				// if the weight of the cards in the current index is larger than the weight of the cards in the next index // 
				if (_cards[j]->getWeight() > _cards[j + 1]->getWeight())
				{
					// swap // 
					Card* temp = _cards[j + 1];
					_cards[j + 1] = _cards[j];
					_cards[j] = temp;
				}
			}
		}
	}

	bool Hand::isContain(int value, char suit)
	{
		for (int i = 0; i < _cards.size(); i++)
		{
			if (_cards[i]->getValue() == value && _cards[i]->getSuit() == suit)      // If the card with the sepecified value and suit is in the container //  
			{                                                                        // Remove the card from the container //  
				return true;											             // Return the pointer the cards that remove from from the container //  
			}
		}
		return false;
	}

	int Hand::isContain(int weight)
	{
		for (int i = 0; i < _cards.size(); i++)
		{
			if (_cards[i]->getWeight() == weight)      // If the card with the sepecified weight is in the container //  
			{                                          // Remove the card from the container //  
				return i;							   // Return the pointer the cards that remove from from the container //  
			}
		}
		return -1;
	}

	void Hand::setOneCardinHand()
	{
		_isOneCardinHand = true;
	}

	bool Hand::isOneCardinHand()
	{
		return _isOneCardinHand;
	}

	Hand::~Hand()
	{
	}

