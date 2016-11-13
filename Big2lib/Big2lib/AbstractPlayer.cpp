#include "stdafx.h"
#include "AbstractPlayer.h"
#include "Hand.h"

using namespace AbstractPlayerCode ;

	AbstractPlayer::AbstractPlayer()
	{
		_score = 200;                                       // Init the total score to 200   //
		_penaltyScore = 0;                                  // Init the penaltyScore to 0    //
                             
	}
	AbstractPlayer::~AbstractPlayer()
	{
	}

	int AbstractPlayer::getPenaltyScore() const
	{
		return _penaltyScore;
	}

	void AbstractPlayer::addPenaltyScore(int _score)
	{
		_penaltyScore += _score;                                 
	}

	void AbstractPlayer::resetPenaltyScore()
	{
		_penaltyScore = 0;
	}

	int AbstractPlayer::getScore()
	{
		return _score;
	}

	void AbstractPlayer::setScore(int x)
	{
		_score = x;
	}


