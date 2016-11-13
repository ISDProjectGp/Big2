#ifndef  _ABSTRACT_PLAYER_H_
#define  _ABSTRACT_PLAYER_H_
#include "AbstractPlayer.h"
#include "Hand.h"

using namespace AbstractPlayerCode;
using namespace HandCode;

namespace PlayerCode {

	// The class of player , store his hand // 
	class Player : public AbstractPlayer
	{
	private:
		Hand* _hand;                    // Pointer point to player's hand  //
	public:

		/*
		* Init the player
		* @note create the hand object 
		*/
		Player();

		/*
		* Destruct the Player
		* @note Delete the hand object in player
		*/
		~Player();

		/*
		* Caculate the total score of the player
		* @note Each call will (Total score - Penalty score) 
		*/
		virtual void win();

		/*
		* Get the address of the hand object in player
		* @return  the address of the hand object
		*/
		Hand& gethand();

	};
}

#endif
