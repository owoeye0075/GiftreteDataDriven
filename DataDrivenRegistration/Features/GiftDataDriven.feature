Feature: GiftDataDriven
	 As a User
	 In order to use Giftrete Website
	 I will need to first register


@mytag
Scenario: Registration Valid Registration
Given that the user navigate to "https://www.qa.giftrete.com"
	And user click create account 
	And userenter First Name "Tomilola"
	And user enter Last Name "Owoeye"
	And user enter email address "rebecca.abe@yahoo.com"
	And user enter mobile number "07459014352"
	And user eneter password "Omoalara234"
	And user re-enter the password "Omoalara234"
	And user validate the captcha 
	When user click register 
	Then user should be successfully registered 