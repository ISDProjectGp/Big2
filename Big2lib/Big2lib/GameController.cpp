#include "stdafx.h"
#include <iostream>
#include "GameController.h"
#include "Dualer.h"
#include "Player.h"
#include "Play.h"
using namespace GameControllerCode;
using namespace PlayerCode;

GameController::GameController()
{
	// Init for the new object // 
	players = new Player[4];
	dealer = new Dealer(deck = new Deck());
	tempPlay = new Play[4];
	inputValue = new int[5];
	inputSuit = new char[5];

	// Init for the variable that controlling each turn //
	turn = 0;
	numberOfInput = 0;
	nextround = false;

	// Init for the variable that contolling each round // 
	win = false;
	secondRound = false;
}

void GameController::play()
{
	// Init for variable when ending a round  // 
	turn = 0;
	numberOfInput = 0;
	secondRound = true;
	win = false;

	// Clear the value of the variable when ending a round  // 
	for (int i = 0; i < 4; i++)
	{
		players[i].gethand().clear();
		tempPlay[i].clear();
	}
	for (int i = 0; i < 5; i++)
	{
		inputValue[i] = 0;
		inputSuit[i] = 0;
	}
	deck->createDeck();
}

void GameController::shuffleAndDual()
	{
		// Shuffle the cards //
		dealer->shuffle();
		// Dual cards to each players //
		for (int j = 0; j < 4; j++)
		{
			for (int i = 0; i < 13; i++)
			{
				dealer->deal(players[j].gethand());
			}
		}
	// Check diamond three  , if it is second round or more , no need to check that//
	if (secondRound == false) 
	{
		for (int j = 0; j < 4; j++)
		{
			if (players[j].gethand().isContainDiamondThree())
			{
				// set the first turn to the player who got Diamond three
				turn = j;
				break;
			}
		}
	}
	else 
	{
		// set the first turn to the player who is the last round winner // 
		turn = winner;
	}
}

int GameController::DisplayCard(int n,int num)
{
	// Check the index of the cards which is valid // 
	if (num < players[n].gethand().getNoCard())
	{
		return players[n].gethand().getCards(num)->getWeight();
	}
	return 0;

}

void GameControllerCode::GameController::sortCard()
{
	players[turn].gethand().sortCards();
}



bool GameController::inputCard(int weight)
{
	// if the number of cards that want to release is less than or equal to 5 // 
	if (numberOfInput <= 5) {
		// if the cards want to release is not in player hand // 
		if (players[turn].gethand().isContain(weight) == -1)
		{
			return false;                       // return invalid // 
		}
		else
		{			
			inputValue[numberOfInput] = players[turn].gethand().getCards(players[turn].gethand().isContain(weight))->getValue();
			inputSuit[numberOfInput] = players[turn].gethand().getCards(players[turn].gethand().isContain(weight))->getSuit();
			numberOfInput += 1;                 // number of input add one // 
			return true;                        // return valid // 
		}
	}
	return false;                               // return invalid // 
}

bool GameController::release()
{
	nextround = false;
	tempPlay[turn].clear();
	// Check the first round for release diamond three // 
	if (players[turn].gethand().isContainDiamondThree() && players[turn].gethand().getNoCard() == 13 && secondRound == false)
	{
		bool releaseContainThree = false;
		for (int i = 0; i < numberOfInput; i++)
		{
			// if the cards want to release containing value 3 
			if (inputValue[i] == 3)
			{
				releaseContainThree = true;
				break;
			}
		}
		// if the cards want to release not containing value 3 
		if (releaseContainThree == false)
		{
			numberOfInput = 0; 
			return false;                     //return invalid // 
		}
	}

	// Release the player cards and add to play // 
	for (int i = 0; i < numberOfInput; i++)
	{
		tempPlay[turn].add(players[turn].gethand().release(inputValue[i], inputSuit[i]));
	}

	// check cards that want to release is a valid format and comapre with cards released by the last player // 
	if (tempPlay[turn].isValidPlay())
	{
		int lastPlay = CheckPass(turn, tempPlay);              // return the last player index which is not pass
		// If the last player index which is not pass is not the current player
		if (lastPlay != turn)
		{
			nextround = comparePlay(&tempPlay[turn], &tempPlay[lastPlay]);
		}
		// If the last player index which is not pass is equal to the current player
		else if (tempPlay[turn].getNoCard() != 0)
		{
			nextround = true;
		}
		else
		{
			numberOfInput = 0;
			nextround = false;
		}
	}
	// IF it is not valid // 
	if (!nextround)
	{
		// Return the cards in play to player hands
		for (int i = 0; i < tempPlay[turn].getNoCard(); i++)
		{
			players[turn].gethand().add(*(tempPlay[turn].release() + i));
		}

	}
	else
	{
		// To next turn // 
		turn += 1;
		isOneCard();
		if (turn == 4)
		{
			turn = 0;
		}
	}

	numberOfInput = 0;
	return nextround;
}

bool GameController::checkWin()
{
	for (int i = 0; i < 4;  i++)
	{
		// if a player have zero cards in hands//
		if (players[i].gethand().getNoCard() == 0)
		{
			win = true;
			winner = i;
		}
	}

	return win;
}

int GameController::getWinner() 
{
	return winner;
}

int GameController::getPenaltyScore(int player)
{
	AbstractPlayer* playerss = &players[player];
	return playerss->getPenaltyScore();
}

int GameController::getScore(int player)
{
	AbstractPlayer* playerss = &players[player];
	return playerss->getScore();
}

void GameController::caculatePenaltyScore()
{
	// Caculate the penalty score for each player // 
	for (int i = 0; i < 4; i++) 
	{
			AbstractPlayer* player = &players[i];
			player->resetPenaltyScore();
			if (getHandNo(i) <= 9)                         // if the number of cards in hand is <= 9 , each cards scored 1 marks 
			{
				player->addPenaltyScore(getHandNo(i)*1);
			}
			else 
			if (getHandNo(i) <= 12)                        // if the number of cards in hand is <= 12 , each cards scored 2 marks 
			{
				player->addPenaltyScore(getHandNo(i)*2);
			}
			else
			if (getHandNo(i) == 13)                        // if the number of cards in hand is == 12 , each cards scored 3 marks 
			{
				player->addPenaltyScore(getHandNo(i)*3);
			}
	}
}

void GameController::caculateTotalScore()
{
	for (int i = 0; i < 4; i++) 
	{
		players[i].win();
	}
}

void GameController::isOneCard()
{
	for (int i = 0; i < 4; i++) 
	{
		if (getHandNo(i)<=1) 
		{  
			players->gethand().setOneCardinHand();
		}
	}
}

bool GameController::isOneCard(int playerno)
{
	return players[playerno].gethand().isOneCardinHand();
}
void GameController::setScore(int score , int playerno)
{
	AbstractPlayer* player = &players[playerno];
	player->setScore(score);
}
int GameController::getTurn()
{
		return turn;
}

int GameController::getHandNo(int playerno)
{
	return players[playerno].gethand().getNoCard();                // return the number of cards in player hand // 
}

GameController::~GameController()
{
	delete[] players;
	delete dealer;
	delete[] tempPlay ;
	delete[] inputValue ;
	delete[] inputSuit ;
}

bool GameController::comparePlay(Play * nowTurnPlay, Play * lastTurnPlay)
{
	// If the number of cards is 0  ,  pass  //                             
	if (nowTurnPlay->getNoCard() == 0)
	{
		return true;                // return valid //
	}
	// If same type //
	else if (nowTurnPlay->getType() == lastTurnPlay->getType())
	{   // If the type is flush //
		if (nowTurnPlay->getType() == 5) 
		{   // If the suit is the same //
			if (nowTurnPlay->getSuit() == lastTurnPlay->getSuit()) 
			{   // If the weight is larger //
				if (nowTurnPlay->getWeight() > lastTurnPlay->getWeight())
				{
					return true;             // return valid //
				} 
				else
				{
					return false;
				}
			}    // If the suit is larger //
			else if (nowTurnPlay->getSuit() > lastTurnPlay->getSuit())
			{
				return true;
			}
			else // If the suit is smaller //
			{
				return false;
			}
		} 		// If weight is bigger //
		else if (nowTurnPlay->getWeight() > lastTurnPlay->getWeight())
		{
			
			return true;             // return valid //
		}
	}
	// If larger type //
	else if (nowTurnPlay->getType() > lastTurnPlay->getType() && lastTurnPlay->getType() > 3)
	{
		return true;                 // return valid //
	}
	return false; // return invalid //
}



int GameController::CheckPass(int index, Play * play)
{
	for (int i = index - 1; i >= 0; i--)
	{
		// if the player with specified index hands has 0 number of cards // 
		if ((play + i)->getNoCard() != 0)
		{
			return i;
		}
	}
	for (int i = 3; i > index; i--)
	{
		// if the player with specified index hands has 0 number of cards // 
		if ((play + i)->getNoCard() != 0)
		{
			return i;
		}

	}
	return index;            // return the index of last player who is not pass
}