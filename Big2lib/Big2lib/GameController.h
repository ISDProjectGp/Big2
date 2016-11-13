#ifndef  GAMECONTROLLER_H
#define  GAMECONTROLLER_H
#include "Play.h"
#include "Dualer.h"
#include "Player.h"

using namespace PlayCode;
using namespace PlayerCode;
using namespace DealerCode;

namespace GameControllerCode
{
	// The class contol all the process , the operation of the game , containing all the object need in the game // 
	// The only class needed to be create for GUI // 
	public ref class GameController
	{
	private:

		// Variable for controlling each turns // 
		int turn;                          // Current player index  (0-3)    //
		int *inputValue;                   // Store the current turn's input //
		char *inputSuit;                   // Store the current turn's input //
		int numberOfInput;                 // Store the current turn's number of the input //
		bool nextround;                    // A boolean to indicate is it valid for next turns //
										   // True   -> Can go to next round , False - > cannot go to next round // 
		// 

		// Variable for controlling each Rounds // 
		int winner;                        // Store the winner player index // 
		bool win;                          // A boolean indicate that a winner win a round //
										   // True   -> A player release all the card , False -> no player win at this moment // 
		bool secondRound;                  // A boolean indicate that is the second round or more  //
		//  

		// Variable for point to the created object in GameController // 
		Player* players;                   // Point to the array that store 4 players // 
		Dealer* dealer;                    // Point to Dualer // 
		Play* tempPlay;                    // Point to the array that store 4 play which store the cards the players release in each turn // 
		Deck* deck;                        // Point to Deck   //
		//

		/*
		* Check the is the cards released by the current player is larger that the cards released by the last player
		* @param  nowTurnPlay   the play of this turn
		*         lastTurnPlay  the play of last turn
		* @return 1. True      If the play(released cards) of the current turn is larger than the last turn
		*         1. False     If the play(released cards) of the current turn is smaller than the last turn
		*/
		bool comparePlay(Play* nowTurnPlay, Play* lastTurnPlay);

		/*
		* Return the player index who is not passed before the current player
		* @param  index         index of current player
		*         play          pointer of tha array of play
		* @return the player index who is not passed before the current player
		*/
		int CheckPass(int index, Play * play);

		/*
		* Check if only one card is in the players hand
		*/
		void isOneCard();
	public:
		GameController();
		~GameController();

		/*
		* Shuffle and Dual the Card
		*/
		void shuffleAndDual();

		/*
		* Return the weight of the cards in players hand
		* @param  index         index of the player (0-3)
		*         num           index of the card in players hand
		* @return the weight of the cards
		*/
		int DisplayCard(int turn, int num);

		/*
		* Sort the cards in current players hand
		*/
		void sortCard();

		/*
		* Input the cards that is willing to release for current round players
		* @param  weight        the cards wieght
		* @return 1. true       If the cards is in current player hands
		*         2. false      If the cards is not in current player hands
		*/
		bool inputCard(int weight);

		/*
		* Release the cards that have been inputed before
		* @return 1. true       Successfully release , go to next round
		*         2. false      not successfully release , NoOfInput set to zero , need to re-input again
		*/
		bool release();

		/*
		* Check if there is player with 0 cards
		* @return 1. true       there is player with 0 cards
		*         2. false      there is not player with 0 cards
		*/
		bool checkWin();

		/*
		* Use when start another round of game , re-init all the variable
		*/
		void play();

		/*
		* Return the current turn
		* @return the current turn
		*/
		int getTurn();

		/*
		* Return the number of the cards in player hand
		* @param  playerno      the index of player (ranging from 0-3)
		* @return the number of the cards in player hand
		*/
		int getHandNo(int playerno);

		/*
		* Return index of player that winned in last round
		* @return index of player that winned in last round
		*/
		int getWinner();

		/*
		* Return the penaltyScore of the player
		* @param  playerno      the index of player (ranging from 0-3)
		* @return the penaltyScore of the player
		*/
		int getPenaltyScore(int player);

		/*
		* Return the total score of the player
		* @param  playerno      the index of player (ranging from 0-3)
		* @return the totalScore of the player
		*/
		int getScore(int player);

		/*
		* Caculate the penalty score of all player at a round
		*/
		void caculatePenaltyScore();

		/*
		* Caculate the total score of player at a round
		*/
		void caculateTotalScore();

		/*
		* Return the boolean that indicate only one or less card is in the players hand
		* @param  playerno      the index of player (ranging from 0-3)
		* @return the boolean   indicate that if only one card is in the player's hand
		*/
		bool isOneCard(int playerno);

		/*
		* Set the total score of the player
		* @param score  the total score add to the player
		*/
		void setScore(int score, int playerno);
	};
}



#endif 

