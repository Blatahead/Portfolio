var burgerState = false
function BurgerTranslate(){
	if(burgerState==false){
		document.getElementById("navbar-nav").style.right="0%"
		burgerState=true
	}else{
		document.getElementById("navbar-nav").style.right="-100%"
		burgerState=false
	}
}