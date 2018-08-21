Feature: Search
user can search content of website

@Search
Scenario Outline: Search content of website
	Given I am in home page
	When I enter <searchcontent>
	Then I can see the result that I expect
    Examples:
    | searchcontent |
    | meet our team |
    | jenny         |