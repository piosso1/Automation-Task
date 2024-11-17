Feature: Buying Item from Sauce Lab

//Buying T shirt from sauce lap web app

Scenario: Buying a T-shirt from sauce lab
	Given User is on the Sauce Labs page
    When User log in with valid credentials
    And User verify that the product catalog is dispalayed
    And User add a T-shirt to the shopping cart
    And User proceed to the checkout
    And User provide valid shipping details
    And User complete the purchase
    Then User should see a confirmation message for the successful order
