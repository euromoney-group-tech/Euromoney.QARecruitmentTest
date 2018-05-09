Feature: EuromoneyPortfolio
	In order to **promote out portfolio**
	As a **user**  
	I want to **view a list and navigate to other brands**


 Scenario: Navigating to the Portfolio Page
  Given I am on the Euromoney Homepage from and I click on the Navigation Menu Bar
   When I click on the link "Our Portfolio"
   And I click on the link "Pricing, data and market intelligence"
   Then I am navigated to the specified Portfolio Page

Scenario: Verifying if IJ Global link is visible
     Given I am on Pricing, data and market intelligence Homepage
	 And I click on 'https://ijglobal.com/'
	 Then the site logs me into the brand and I am in the Home page "IJGlobal | Infrastructure Journal and Project Finance Magazine"

Scenario Outline: Verifying if the League Table Section is display on the brand page
   Given I am on the brand Homepage "IJGlobal | Infrastructure Journal and Project Finance Magazine" 
   Then I verify <LeagueTableSectionDetails> on the page

   Examples:
     
    | LeagueTableSectionDetails |
	| Rank |
    | Company |
	| Total(USDm) |
	| Transactions |
	| MarketShare |
 

	  
