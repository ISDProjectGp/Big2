#include "stdafx.h"
#include <iostream>
#include "Play.h"
using namespace std;

using namespace PlayCode;
using namespace CardCode;

	Play::Play()
	{
		_playCards = new Card*[5];                   // Create the array of cards // 
		_numOfCard = 0;
		_weight = 0;
		_type = 0;
	}

	int Play::getNoCard() const
	{
		return _numOfCard;                           // return the number of cards in the play // 
	}

	void Play::clear()
	{
		_numOfCard = 0;                              // set the number of cards in play to zero // 
	}

	int Play::getType() const
	{
		return _type;                                // Get the type of play // 
	}

	int Play::getWeight() const
	{
		return _weight;                              // Get the weight of play // 
	}

	int Play::getSuit() const
	{
		return _suit;
	}

	int Play::numberOfSameValueCombination(int startIndex, int numberOfCard)
	{
		int numberOfEqualValueCards = 1;
		for (int i = startIndex; i < startIndex + numberOfCard - 1; i++)
		{
			if ((*(_playCards + i))->getValue() == (*(_playCards + i + 1))->getValue())         // If next card get the same value //
			{
				numberOfEqualValueCards += 1;
			}
		}
		return numberOfEqualValueCards;
	}

	bool Play::isValidPlay()
	{
		sortCards();                                           // Sort the cards in plays //
		switch (_numOfCard)
		{
		case 0:
			// If pass //
			return true;
		case 1:
			// If single //
			_weight = (*(_playCards))->getWeight();            // The weight of the play = the weight of that single card //
			_type = 1;
			return true;                                       // return valid //
		case 2:
			// If pair // 
			if (numberOfSameValueCombination(0, 2) == 2)       // If there are two cards with same value //
			{
				_weight = (*(_playCards + 1))->getWeight();    // The weight of the play = the weight of the card with largest weight in that pair //
				_type = 2;
				return true;                                   // return valid //
			}
			break;
		case 3:
			// If Three of a kind // 
			if (numberOfSameValueCombination(0, 3) == 3)       // If there are three cards with same value //
			{
				_weight = (*(_playCards + 2))->getWeight();    // The weight of the play = the weight of the card with largest weight in Three of a kind //
				_type = 3;
				return true;                                   // return valid //
			}
			break;
		case 5:
			if (numberOfSameValueCombination(0, 5) == 4)              // If there are (four cards with same value) or (three cards with same value and the remaining two cards with same value) //  
			{
				if ((numberOfSameValueCombination(0, 2) == 2) && (numberOfSameValueCombination(3, 2) == 2)) // If not four cards with same value // 
				{
					// If Straight //
					if (numberOfSameValueCombination(0, 3) == 3)      // Check the postion of that three cards with same value // 
					{
						_weight = (*(_playCards + 2))->getWeight();   // The weight of the play = the weight of the card with largest weight in Three of a kind (in that three cards) //
					}
					else
					{
						_weight = (*(_playCards + 4))->getWeight();   // The weight of the play = the weight of the card with largest weight in Three of a kind (in that three cards) //
					}
					_type = 6;
					return true;	                                  // return valid //
				}
				else
				{
					// If Four of a Kind // 
					if (numberOfSameValueCombination(0, 3) == 4)      // Check the postion of that four cards with same value // 
					{
						_weight = (*(_playCards + 3))->getWeight();   // The weight of the play = the weight of the card with largest weight in Four of a Kind (in that four cards) //
					}
					else
					{
						_weight = (*(_playCards + 1))->getWeight();   // The weight of the play = the weight of the card with largest weight in Four of a Kind (in that four cards) //
					}
					_type = 7;
					return true;                                      // return valid //
				}
			}
			else if (isContinuousNumber())
			{
				_weight = (*(_playCards + 4))->getWeight();  // The weight of the play = the weight of the card with largest weight in Straight Flush /Straight  //
															 // If Straight Flush // 										  
				if (isSuit())
				{
					_type = 8;
					return true;                             // return valid //

				}
				// If Straight // 
				else
				{
					_type = 4;
					return true;                             // return valid //
				}
			}
			// If Flush // 
			else if (isSuit())
			{
				_weight = (*(_playCards + 4))->getWeight(); // The weight of the play = the weight of the card with largest weight in Flush  //
				_type = 5;
				return true;                                // return valid //
			}
			break;
		}

		return false;                                       // return invalid //
	}

	bool Play::isContinuousNumber()
	{
		// If 10 J Q K A  //
		if ((((*(_playCards ))->getValue()) == 10) && (((*(_playCards + 1))->getValue()) == 11) && (((*(_playCards +2 ))->getValue()) == 12) && (((*(_playCards + 3))->getValue()) == 13) && (((*(_playCards+4))->getValue()) == 1))
		{
			return true;
		}
		for (int i = 0; i<_numOfCard - 1; i++)
		{
			// If there is a number that is not continue //
			if (((*(_playCards + i + 1))->getValue()) != ((*(_playCards + i))->getValue()) + 1)
			{
			   	return false;
			}
		}
		return true;
	}

	bool Play::isSuit()
	{
		for (int i = 0; i < _numOfCard - 1; i++)
		{
			// If there is a cards with the suit that is not the same as the cards before //
			if ((*(_playCards + i))->getSuit() != (*(_playCards + i + 1))->getSuit())
			{
				return false;
			}
		}
		char suit[4] = { 'D','C','H','S' };
		for (int i = 0; i < 4; i++)
		{
			if ((*(_playCards))->getSuit() == suit[i])
			{
				_suit = i;
			}
		}
		return true;
	}

	bool Play::add(Card* card)
	{
		// If the number of cards index in play is less than 5 // 
		if (_numOfCard < 5)
		{
			_playCards[_numOfCard] = card;          // Add the cards to play //
			_numOfCard += 1;                        // The number of cards in play add one //
			return true;
		}
		return false;
	}

	Card** Play::release()
	{
		// If the number of cards in play is not zero // 
		if (_numOfCard != 0)               
		{
			return _playCards;
		}
		return nullptr;
	}

	void Play::sortCards()
	{
		for (int i = 0; i < _numOfCard - 1; i++)
		{
			for (int j = 0; j < _numOfCard - 1 - i; j++)
			{
				// if the weight of the cards in last index is larger than the weight of the cards in the curren index // 
				if ((*(_playCards + j))->getWeight() >(*(_playCards + j + 1))->getWeight())
				{
					// swap // 
					Card* temp = *(_playCards + j);
					*(_playCards + j) = *(_playCards + j + 1);
					*(_playCards + j + 1) = temp;
				}
			}
		}
	}

	Play::~Play()
	{
		delete[] _playCards;              // Delete the array of the cards pointer //      
	}
