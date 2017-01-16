﻿Feature: General Smoke Test

	Scenario: Tap Add Callendar
		Given I can see "Add calendar event" button
		When  I tap "Add calendar event" button
		Then I can see "Add calendar event" button

	Scenario: Tap Go Online Forms 1
		Given I can see "Go online forms 1" button
		When I tap "Go online forms 1" button
		Then I can see "Online Form" screen
		When I fill the Online Form 1
		And I tap "Submit" button
		Then I can see "Results" screen
		When I tap "Sign it!" button
		Then I can see "Signature" screen
		When I perform a signature
		And I tap "Results" button
		Then I can see "Results" screen
		When I scroll down to Sign In button
		And I tap "Sign it!" button
		#Then I can see "Results" screen

		#Given Launch Repl

	Scenario: Tap Go Online Forms 2
		Given I can see "Go online forms 2" button
		When I tap "Go online forms 2" button
		Then I can see "Online Form" screen

	Scenario: Show PDF
		Given I can see "Show PDF" button
		When  I tap "Show PDF" button
		Then Popup appears "Do you want to open in external viewer?"

		When I tap "Cancel" button
		Then I can see "PDFView" screen

	#Scenario: Launch Repl app
	#	Given Launch Repl
