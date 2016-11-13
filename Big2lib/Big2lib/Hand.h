#ifndef  _HAND_H_
#define  _HAND_H_
#include "Card.h"
#include <vector>
using namespace std;

using namespace CardCode;

namespace HandCode {

	// The class store the cards in player hand and the method to hand that cards // 
	class Hand
	{
	private:
		vector<Card*> _cards;                     // A container to store the pointer of the cards //
		bool _isContainDiamondThree;              // A boolean that indicate there is diamond three in the hand // 
		bool _isOneCardinHand;                    // A boolean that indicate there is only one card in hand //                  

	public:
		/*
		* Init the card
		* @note initially isContainDiamondThree is set to false
		*/
		Hand();

		/*
		* Destruct the Hand
		* @note No variable in this method are deleted (No need to call this method in this moment)
		*/
		~Hand();

		/*
		* Get the number of card in the hand
		* @return the number of card
		*/
		int getNoCard() const;

		/*
		* Get the pointer of the card in hand
		* @param  index   the index of the card in hand
		* @return 1. If the card with the index is in hand  , return the pointer of the card
		*         2. If the the index exeed bound           , return nullptr
		*/
		Card* getCards(int index) const;

		/*
		* Return the boolean value that indicate if there are diamond three in hand
		* @return the boolean value
		* @note   If Diamond three is in hand     , return true
		*         If Diamond three is not in hand , return false
		*/
		bool isContainDiamondThree() const;

		/*
		* Add a card to the hand , if the card is diamond three , isContainDiamondThree = true
		* @param  card   the pointer of the card
		* @return boolean value that indicate successful add the card or not
		* @note   If the number of cards in hand > 13 , return true  , successfully add the card to hand
		*         If the number of cards in hand < 13 , return false , not successfully add the card to hand
		*/
		bool add(Card* card);

		/*
		* Remove a card from hand
		* @param  value   the value of the card
		*         suit    the suit of the card
		* @return 1. The pointer of card that you have been removed from hand(If the card is in hand)
		*         2. nullptr (If the card is not in hand)
		*/
		Card* release(int value, char suit);

		/*
		* Clear all the card in hand
		*/
		void clear();

		/*
		* Sorts the cards in hand 
		*/
		void sortCards();

		/*
		* Check the if the hand conatining a card with the specified suit and value 
		* @param  value   the value of the card
		*         suit    the suit of the card
		* @return 1. True    if hand contain card with the specified suit and value
		*         2. False   if hand is not contain card with the specified suit and value
		*/
		bool isContain(int value, char suit);

		/*
		* Check the if the hand conatining a card with the specified weight
		* @param  value   the weight of the card
		* @return 1. the index of the card with the specified weight
		*         2. -1 if the hand not contain that with the specified weight
		*/
		int isContain(int weight);

		// Set if player only have one card in his hand //
		void setOneCardinHand();

		/*
		* Return the boolean that indicate only one or less card is in the players hand
		* @param  playerno      the index of player (ranging from 0-3)
		* @return the boolean   indicate that if only one card is in the player's hand
		*/
		bool isOneCardinHand();
		
	};
}
#endif 

