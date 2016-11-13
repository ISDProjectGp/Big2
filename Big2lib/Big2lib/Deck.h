#ifndef  _DECK_H_
#define  _DECK_H_
#include "Card.h"

using namespace CardCode;

namespace DeckCode {

	// The class collected 52 cards object //
	class Deck
	{
	private:
		int _numOfCard;                   // To set the nmber of card in Deck // 
		Card* _cards;                     // To store the cards object        // 
		const int DECK_CAPACITY = 52;     // A constant varaible to store the number of the card in deck// 
	public:
		/*
		* Init the Deck
		* @note Init the card object 
        *       Init _numOfCard to 52 
		*/
		Deck();

		/*
		* Destruct the Deck
		* @note Delete the card object in deck
		*/
		~Deck();

		/*
		* Get the pointer of the card with the index with randing from 0 to 51 (For Dualer to swap)
		* @return  the pointer of the card card with the index
		* @note    1. If the index is from 0 - 51  , return the pointer of the card
		*          2. If the index is out of range , return nullptr
		*/
		Card* getCard(int index) const;

		/*
		* Get the number of cards in deck
		* @note If all the cards are dualed by dualer , return 0
		*       If no cards are dualed by dualer      , return 52 (After creating the deck)
		*/
		int getNoCard() const;

		/*
		* Get the pointer of card with largest index (For dualer to dual , decrease the number of card in deck)
		* @return  the pointer of the card card with largest index
		* @note    1. If the number of the card in deck > 0 , return the pointer of the card
		*          2. If the number of the card in deck < 1 , return nullptr
		*/
		Card* getCard();

		/*
		* Initialize the deck by setting the value,suit and weight of the cards by accending order
		*/
		void createDeck();

		/*
		* Delete all 52 cards object in the deck and create new 52 object
		*/
		void clear();
	};
}
#endif
