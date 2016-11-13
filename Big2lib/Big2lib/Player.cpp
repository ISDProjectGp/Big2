#include "stdafx.h"
#include "Player.h"
#include "Hand.h"

using namespace PlayerCode ;
using namespace HandCode;

	Player::Player()
	{
		_hand = new Hand();
	}

	Player::~Player()
	{
		delete _hand;
	}

	void Player::win() 
	{
		_score -= _penaltyScore;         // Decrease the total score of player //
		resetPenaltyScore();             // Reset the penalty score // 
	}

	Hand& Player::gethand()
	{
		return *_hand;                   // Reuturn the address of the hand in player // 
	}
