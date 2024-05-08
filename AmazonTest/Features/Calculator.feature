Feature: Cart Validation

@amazon
Scenario: validate item and amount 
	Given navigate to the amazon as an unregistered user
	| Browser | URL                     | OS         |
	| chrome  | https://www.amazon.com/ | Windows 10 |
	When Search for TP-link
	| Search item                                                              |
	| TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N) |
	And Add the corresponding item to the cart
	Then Navigate to cart and validate the correct item and amount is displayed