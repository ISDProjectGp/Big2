#include "stdafx.h"
#include "Card.h"

using namespace CardCode;

	Card::Card()
	{
		_isSelected = false;
	}

	int Card::getValue() const
	{
		return _value;
	}

	char Card::getSuit() const
	{
		return _suit;
	}

	int Card::getWeight() const
	{
		return _weight;
	}

	void Card::setValue(int value)
	{
		_value = value;
	}

	void Card::setSuit(char suit)
	{
		_suit = suit;
	}

	void Card::setWeight(int weight)
	{
		_weight = weight;
	}

	bool Card::isSelected() const
	{
		return _isSelected;
	}

	void Card::toggle()
	{
		if (_isSelected)
		{
			_isSelected = false;
		}
		else
		{
			_isSelected = true;
		}
	}

	Card::~Card()
	{
	}

