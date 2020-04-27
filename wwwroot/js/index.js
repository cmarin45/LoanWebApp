/*
	index.js
*/
$(document).ready(function () {
	var submit = $("#cerere");
	submit.on("click", function () {
		console.log("Cerere trimisa");
	});

	var $loginToggle = $("#loginToggle");
	var $popup = $(".popup");

	$loginToggle.on("click", function () {
		$popup.toggle(500);
	});
});