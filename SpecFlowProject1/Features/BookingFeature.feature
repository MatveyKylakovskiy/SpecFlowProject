
@CloseBrowser

Feature: BookingFeature

@mytag
Scenario Outline:: CheckBooking

	Given Open Page https://www.booking.com/searchresults.en-gb.html
	When Input hotel name <HotelName>
	And Search the hotel
	And Skip the pop-up window
	Then Check rating. Expected is <Rating>


	Examples:
	| HotelName		     |  Rating    |
	| Gwesty Seren Hotel |	  8,4	  |
	| DFT Apartment		 |    5,2	  |
	| Ty Ty TownHouse    |    9,0	  |
	| La Roulotte au Par |    9,1	  |