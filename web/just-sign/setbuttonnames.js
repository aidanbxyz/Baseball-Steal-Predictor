function setbuttonnames() {
    document.getElementById("regbutton").style.backgroundColor = '#0000ff';
    document.getElementById("regbutton").innerHTML = 'REGISTERED';
    var q = document.getElementById("1").value;
    var w = document.getElementById("2").value;
    var e = document.getElementById("3").value;
    var r = document.getElementById("4").value;
    var t = document.getElementById("5").value;
    var y = document.getElementById("6").value;
    var u = document.getElementById("7").value;
    var i = document.getElementById("8").value;
    var o = document.getElementById("9").value;
    var p = document.getElementById("0").value;
    document.getElementById("01").innerHTML = q;
    document.getElementById("02").innerHTML = w;
    document.getElementById("03").innerHTML = e;
    document.getElementById("04").innerHTML = r;
    document.getElementById("05").innerHTML = t;
    document.getElementById("06").innerHTML = y;
    document.getElementById("07").innerHTML = u;
    document.getElementById("08").innerHTML = i;
    document.getElementById("09").innerHTML = o;
    document.getElementById("00").innerHTML = p;
    setTimeout(() => { document.getElementById("regbutton").style.backgroundColor = ''; document.getElementById("regbutton").innerHTML = 'REGISTER'; }, 2000);
}