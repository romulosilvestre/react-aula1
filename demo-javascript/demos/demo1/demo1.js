
/*
    id - #
    class - .
    tag "form"  - use o nome da tag
*/
//DOM - manipulação de um árvore de componentes HTML no JS
const frm = document.querySelector("form")
const resp = document.querySelector("h3")

//Ouvinte - evento - submeter um formulário (submit)

frm.addEventListener("submit",(e)=>{

      const nome = frm.txtNome.value
      //innerText -<p>, <h1>, <h2>, <span>,<div>
      //innerHtml -<p>, <h1>, <h2>, <span>,<div>
      //value - campos de formulário
      resp.innerText = `Olá ${nome}`
      e.preventDefault() //evitar o envio do form

})