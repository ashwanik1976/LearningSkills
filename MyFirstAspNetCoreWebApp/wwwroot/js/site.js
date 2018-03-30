// Write your Javascript code.
(function() {
    hello("Hello12s!");
    function hello(greeting) {
        const elm = document.querySelector("p");
        const text = '$(greeting)world!!!'
        elm.innerHTML = text;

    }
})();
