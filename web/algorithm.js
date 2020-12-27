function runmainalg() {
    var cssinputbox = document.getElementById("csignset").value;
    var csswassteal = document.getElementById("csswassteal").value;

    var allarray = document.getElementById("allarr");
    var allarr = allarray.innerHTML;
    allarray.innerHTML = allarr + ' ' + cssinputbox;

    var allstarray = document.getElementById("allstarray");
    var allst = allstarray.innerHTML;
    allstarray.innerHTML = allst + ' ' + csswassteal;

    var table = document.getElementById("datatable");
    var row = table.insertRow(table.rows.length);
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    cell1.align = "center";
    cell2.align = "center";
    cell1.innerHTML = cssinputbox;
    cell2.innerHTML = csswassteal;
    document.getElementById("csignset").value = '';
    document.getElementById("csswassteal").value = '';
    runcheckalg();
}

function runcheckalg() {
    // parse json
    var allarray = document.getElementById("allarr");
    var allarr = allarray.innerHTML.substring(1).split(' ');
    var allstarray = document.getElementById("allstarray");
    var allst = allstarray.innerHTML.substring(1).split(' ');

    var jsondata = '{';
    for (var i = 0; i < allarr.length; i++) {
        var tmp = allarr[i];
        var tmpnum = 0;
        jsondata += '"' + i + '":[{'
        while (tmp.length >= 2) {
            jsondata += '"' + tmpnum + '":"' + tmp.substring(0, 2) + '"';
            tmpnum++;
            if (tmp.length > 2) { jsondata += '},{'; } else { jsondata += '}'; }
            tmp = tmp.substring(1);
        }
        jsondata += ']';
        if (i < allarr.length - 1) { jsondata += ','; }
    }
    jsondata += '}';
    console.log(jsondata);
    jsondata = JSON.parse(jsondata);
    console.log(jsondata);

    var totalitems = -1;
    var jsonstdata = '{';
    for (var i = 0; i < allst.length; i++) {
        var tmp = allst[i];
        var tmpnum = 0;
        jsonstdata += '"' + i + '":"' + tmp + '"';
        if (i < allst.length - 1) { jsonstdata += ','; }
        totalitems++;
    }
    jsonstdata += '}';
    console.log(jsonstdata);
    jsonstdata = JSON.parse(jsonstdata);
    globalThis.jsondata = jsondata;
    globalThis.jsonstdata = jsonstdata;
    console.log(jsonstdata);

    console.log(allarr);
    console.log(allst);
    console.log(totalitems);
    // end pj


    var possibilities = [];
    for (var i = 0; i <= totalitems; i++) {
        for (var j = 0; j <= jsondata[i].length - 1; j++) {
            console.log(jsondata[i][j][j]);
            for (var k = 0; k <= totalitems; k++) {
                for (var l = 0; l <= jsondata[k].length - 1; l++) {
                    if ((jsondata[k][l][l] == jsondata[i][j][j]) && (jsonstdata[k] == "true") && (jsonstdata[i] == "true") && (k != i)) {
                        console.log('MATCH AT ' + k + l + l + ' AND ' + i + j + j + ' - "' + jsondata[k][l][l] + '"');
                        possibilities.push(jsondata[k][l][l]);
                        possibilities = [...new Set(possibilities)];
                        console.log(possibilities);
                    }
                    for (var f = 0; f <= totalitems; f++) {
                        for (var t = 0; t <= jsondata[f].length - 1; t++) {
                            if (jsonstdata[f] == "false" && jsondata[f][t][t] == jsondata[k][l][l] && possibilities.includes(jsondata[f][t][t])) { possibilities.splice(possibilities.indexOf(jsondata[f][t][t])); }
                        }
                    }
                    for (var f = 0; f <= totalitems; f++) {
                        for (var t = 0; t <= jsondata[f].length - 1; t++) {
                            for (var g = 0; g <= possibilities.length - 1; g++) {
                                console.log(JSON.stringify(jsondata[f]));
                                if (jsonstdata[f] == "true" && !JSON.stringify(jsondata[f]).match(possibilities[g])) { possibilities.splice(possibilities.indexOf(jsondata[f][t][t])); }
                            }
                        }
                    }
                }
            }
        }
    }
    if (possibilities.length != 0) {
        document.getElementById("solution").innerHTML = possibilities;
    } else {
        document.getElementById("solution").innerHTML = 'NONE SO FAR';
    }
}