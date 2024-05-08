Feature: Cart Validation

@amazon
Scenario: validate item and amount 
	Given navigate to amazon as an unregistered user
	When Search for TP-link
	| Search item                                    |
	| TP-Link AX5400 WiFi 6 Router (Archer AX72 Pro) |
	And Add corresponding item to the cart
	Then Navigate to the cart and validate correct item and amount is displayed
	| ProductName																																																| ProductPrice |
	| AX5400 WiFi 6 Router (Archer AX72 Pro) Multi Gigabit Wireless Internet Router, 1 x 2.5 Gbps Port, Dual Band, VPN Router, Guest Network, MU-MIMO, USB 3.0 Port, WPA3, Compatible with Alexa		| $169.99      |