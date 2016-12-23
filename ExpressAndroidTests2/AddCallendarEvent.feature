Feature: General Smoke Test

	Scenario: Tap Add Callendar
		Given I can see "Add calendar event" button
		When  I tap "Add calendar event" buttoon
		Then I can see "Add calendar event" button

	Scenario: Tap Go Online Forms 1
		Given I can see "Go online forms 1" button
		When I tap "Go online forms 1" buttoon
		Then I can see "Online Form" screen

	Scenario: Tap Go Online Forms 2
		Given I can see "Go online forms 2" button
		When I tap "Go online forms 2" buttoon
		Then I can see "Online Form" screen

	Scenario: Show PDF
		Given I can see "Show PDF" button
		When  I tap "Show PDF" buttoon
		Then I can see "PDFView" screen

	#Scenario: Launch Repl app
	#	Given Launch Repl
