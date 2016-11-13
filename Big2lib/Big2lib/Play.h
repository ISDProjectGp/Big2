#ifndef  _PLAY_H_
#define  _PLAY_H_
#include "Card.h"

using namespace CardCode;

namespace PlayCode {

	// The class to store the card that each round player release , mainly use as cards comparison // 
	class Play
	{
	private:

		                        //  0 -> invalid type , 1 -> single, 2 -> pair, 3 -> three of kinds, 4 -> straight , //
		                        //  5 -> flush , 6 -> full house , 7 -> Four of a Kind 8 -> Straight Flush 	         // 
		int _type;              // The type of of the colleaction of the cards in play                               //        	                              
		int _weight;            // The weight of the play      //
		int _numOfCard;         // The number of cards in play //
		int _suit;              // The suit (It is used if flower) //
		Card** _playCards;      // The pointer of pointer to store the memory address of the cards in play //

		/*
		* Find the number of combination of the same value cards in play
		* @param   StartIndex    the start index
		* @param   NumberOfCard  the number of Card
		* @return  The number of the cards that have the same value
		* @note    eg If 11155 , return 4   eg If 111 , return 3
		*          eg If 11551 , return 2   eg If 11  , return 2
		*/
		int numberOfSameValueCombination(int startIndex, int numberOfCard);

		/*
		* Return the boolean value that indicate the value of the all five cards in play are continuous
		* @return  the boolean value
		* @note    eg If 12345 , return true
		*          eg If 12346 , return false
		*/
		bool isContinuousNumber();

		/*
		* Return the boolean value that indicate the suit of the all five cards in play are same
		* @return  the boolean value
		* @note    eg If 52368(All with same suit)     , return true
		*          eg If 52346(NOT All with same suit) , return false
		*/
		bool isSuit();

		/*
		* Sort the cards in play according to the card's weight
		*/
		void sortCards();

	public:
		/*
		* Init the Play
		* @note Init the array to store the card pointer 
		*       Init _numOfCard  , _type , _weight to zero 
		*/
		Play();

		/*
		* Destruct the Play
		* @note delete the array that store the card pointer 
		*/
		~Play();

		/*
		* Get the number of Card in play
		* @return  The number of the cards in play
		*/
		int getNoCard() const;

		/*
		* Return the boolean value that indicate the collection of cards in the play is valid or not ,
		* Also for checking and setting the type and the weight of the play (the collection of cards)
		* @return  1. If the cards are valid     , return true
		*          2. If the cards are not valid , return false
		*/
		bool isValidPlay();

		/*
		* Add a card to the play
		* @para card   the pointer of the card to be added
		* @return If the number of cards in play >= 5 , return false
		*         If the number of cards in play < 5  , return true
		*/
		bool add(Card* card);

		/*
		* Get the cards in play
		* @return If the number of cards in play > 0 , return address of the first pointer of cards in play
		*         If the number of cards in play = 0 , return nullptr
		*/
		Card** release();

		/*
		* Get the cards in play
		* @return If the number of cards in play > 0 , return address of the first pointer of cards in play
		*         If the number of cards in play = 0 , return nullptr
		*/
		void clear();

		/*
		* Get the type of play
		* @return the type of play
		*/
		int getType() const;

		/*
		* Get the weight of play
		* @return the weight of play
		*/
		int getWeight() const;

		/*
		* Get the suit of play
		* @return the suit of play
		* @note only use when compare the flush
		*/
		int getSuit() const;
	};
}

#endif

