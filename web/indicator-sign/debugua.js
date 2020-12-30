setTimeout(() => {
	document.getElementById("debugua").innerHTML = 'For debug purposes:<br>';
	document.getElementById("debugua").innerHTML += navigator.appCodeName;
	document.getElementById("debugua").innerHTML += ' - ';
	document.getElementById("debugua").innerHTML += navigator.appName;
	document.getElementById("debugua").innerHTML += ' - ';
	document.getElementById("debugua").innerHTML += navigator.appVersion;
	document.getElementById("debugua").innerHTML += ' - ';
	document.getElementById("debugua").innerHTML += navigator.cookieEnabled;
	document.getElementById("debugua").innerHTML += ' - ';
	document.getElementById("debugua").innerHTML += navigator.language;
	document.getElementById("debugua").innerHTML += ' - ';
	document.getElementById("debugua").innerHTML += navigator.onLine;
	document.getElementById("debugua").innerHTML += ' - ';
	document.getElementById("debugua").innerHTML += navigator.platform;
	document.getElementById("debugua").innerHTML += ' - ';
	document.getElementById("debugua").innerHTML += navigator.userAgent;
}, 1000);