var box = document.getElementById('display');

function addtoscreen(x){
 box.value+=x;

if(x==='CE'){
		box.value='';
	}
if(x==='AC'){
		box.value='';
	}
if(x==='+/-'){
		box.value='-';
	}
}


function power(){
	x=box.value;
	x=eval(x*x);
	box.value=x;
}

function backspace(){
	var num = box.value;
	var len = num.length-1;
	var newNum = num.substring(0,len);
	box.value = newNum;
}


function answer (){
  x=box.value;
  x=eval(x);
  box.value=x;
  box.innerText = box.innerText.replace(/×/, '*').replace(/÷/, '/');  
}


function pow(){
	x=box.value;
	x=Math.pow(x, 0.5);
	box.value=x;
}

function phantram(){
	x=box.value;
	x=eval(x*0.01);
	box.value=x;
}

function giaithua(){
	x=box.value;
	var j = 1;
		for (var i = 1; i <= x; i++) {
		var j = j*i;}
	box.value=x=j;
}


function powerx(){
	x=box.value;
	x=eval(x*x*x);
	box.value=x;
}



