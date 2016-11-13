#ifndef  _CARD_H_
#define  _CARD_H_
#include "Card.h"

namespace CardCode {

	// The basic card type Class //
	public class Card
	{
	private:
		char _suit;             // To store the suit of the card   (S,H,D,C) //
		int  _value;            // To store the value of the card  (1-13)    // 
		int  _weight;           // To store the weight of the card (0-51)    //
		bool _isSelected;       // To store a boolean which indicate the card that is selected by the player //  

	public:
		/*
		* Init the card
		* @note initially the card is set to be not selected
		*/
		Card();

		/*
		* Destruct the Card
		* @note No variable in this method are deleted (No need to call this method in this moment)
		*/
		~Card();

		/*
		* Get the value of the card
		* @return value the value of the card
		*/
		int  getValue() const;

		/*
		* Get the suit of the card
		* @return the suit of the card
		*/
		char getSuit() const;

		/*
		* Get the weight of the card
		* @return the weight of the card
		*/
		int  getWeight() const;

		/*
		* Set the value of the card
		* @param value	the value of the card
		*/
		void setValue(int value);

		/*
		* Set the suit of the card
		* @param suit	the suit of the card
		*/
		void setSuit(char suit);

		/*
		* Set the weight of the card
		* @param weight  the weight of the card
		*/
		void setWeight(int weight);

		/*
		* Return the boolean value that indicate the card that is selected or not
		* @return the boolean value
		* @note   If the card is selected  , return true
		*         If the card not selected , return false
		*/
		bool isSelected() const;

		/*
		* Toogle the card
		* @note  If selected = true , toggle() , then selected = false
		*        If selected = false, toggle() , then selected = true
		*/
		void toggle();
	};
}
#endif

