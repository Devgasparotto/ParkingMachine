# ParkingMachine
An assignment for a Human Computer Interfaces course. The objective was to design an interface for a touch screen (hardware was also included) for a Parking Machine.

INSTRUCTIONS

Hardware Interface Explanation

As the assignment focus was on the Touch Screen and not the Hardware Interface, we have decided to include some notes on the Hardware Interface here.

Hardware buttons will change colour to green to indicate that they should be interacted with. This includes the Swipe Card, Insert Card, Coin Insert, Coin Return, Printed Ticket and Insert Ticket buttons. These buttons will turn green at specific points to signal to the user that they should press these buttons at this point.

There are three combo-boxes for Coin Insert, Tickets, and Cards. Pressing the arrow attached to the Coin Insert box will allow the user to select coins to enter into the machine if they are on the correct screen. Pressing the Coin Insert button will insert the coin selected in the dropdown. This is to simulate putting coins into the actual coin slot that the user would interact with on a real machine.

When selecting a Card from the drop down, information about that card (Credit Card Number, CVV, and PIN) will be displayed. The Card that is currently selected in the drop down will be used for Card Swipe and Card Insert functionality.

When selecting a Ticket from the drop down, information about that ticket (Issue Date, Valid Till Date, Ticket ID) will be displayed. The Ticket that is currently selected in the drop down will be used for Insert Ticket functionality (i.e. Refunding a Ticket, Adding Time to an Existing Ticket).

The sample tickets and cards can be used to test the program for the purpose of showing all different paths possible in the program (card denied, card accepted, ticket refunded, ticket expired, etc.).


For Testing:

Although this is all discoverable through the Hardware Interface, I have included some notes here to help you with testing.
Card 1 will be accepted, letting the user use Insert Card and Swipe Card functionality (PINs for both cards are set to 0000, but you can check this by selecting the card in the Hardware Interface from the dropdown). Card 2 will be declined when using Insert Card and Swipe Card functionality, which will allow manual entry (Card 2’s Credit Card Number is 2222222222222222 and CVV is 321, but you can check this by selecting the card in the Hardware Interface from the dropdown).

Ticket 1 is a non-expired ticket and as such is still active. Ticket 2 is an expired ticket and as a result some functionality is changed (i.e. can’t refund).


How to Run:

The .exe is found in the path “ParkingMachine\bin\Release”, it is called ParkingMachine.exe.
