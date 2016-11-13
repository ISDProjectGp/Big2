#ifndef  _DEALER_H_
#define  _DEALER_H_
#include "Hand.h"
#include "Deck.h"

using namespace DeckCode;
using namespace CardCode;
using namespace HandCode;

namespace DealerCode {

	// The class containing the method to shuffle and dual the card // 
	class Dealer
	{
	private:

		Deck* _deck;                              // Pointer to a deck object , intially store 52 cards // 
		
	    /*
		* Swap two cards
		* @para cardA	the card to be swapped
		* @para cardB	the card to be swapped
		*/
		void swap(Card* cardA, Card* cardB);

	public:
		Dealer();

		/*
		* Init the Dualer
		* @para deck     pointer of a new deck 
		*/
		Dealer(Deck* deck);

		/*
		* Destruct the Dualer
		* @note Delete the deck object in dualer
		*/
		~Dealer();

		/*
		* Shuffle the cards in deck
		* @note  this method will init the cards in deck and then shffle them
		*/
		void shuffle();

		/*
		* Deal a cards to hand
		* @para hand  the hand of a player
		*/
		void deal(Hand& hand);
	};
}
#endif 
