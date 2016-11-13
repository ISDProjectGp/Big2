#ifndef  _ABSTRACTPLAYER_H_
#define  _ABSTRACTPLAYER_H_
#include "Hand.h"
#pragma once

using namespace System;

namespace AbstractPlayerCode {

	// Interface that containing the method to handlling the score caculation of player // 
	class AbstractPlayer
	{
	protected:
		int _score;                                      // To store the total score of a player //
		int _penaltyScore;                               // To store the penaltyScore of player  //
	public:
		/*
		* Init the AbstractPlayer 
		* @note initially _score set to 200 
		*       initially _penaltyScore set to 0
		*/
		AbstractPlayer(); 

		/*
		* Destruct the AbstractPlayer
		* @note No variable in this method are deleted (No need to call this method in this moment)
		*/
		~AbstractPlayer();
		
		/*
		* Return the Penalty Score 
		* @return the penalty score 
		*/
		int getPenaltyScore() const;

		/*
		* Add Penalty Scoore
		* @param score   the penalty score add to the player
		*/
		void addPenaltyScore(int score);

		/*
		* Caculate the total score of the player 
		*/
		virtual void win() = 0;

		/*
		* Reset the penalty score zero
		*/
		void resetPenaltyScore();

		/*
		* Get the total score of the player
		* @return the total score
		*/
		int getScore();

		/*
		* Set the total score of the player
		* @param x  the total score add to the player
		*/
		void setScore(int x);
	};
}
#endif 

