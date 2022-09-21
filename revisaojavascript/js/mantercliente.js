//crie uma referência ao form e ao elemento h3
//DOM
const frm = document.querySelector("form")
const resp = document.querySelector("h3")
//cria um "ouvinte" de evento, 
//acionado quando o botão submit for clicado

frm.addEventListener("submit",(e)=>{
    const nome = frm.inNome.value
    const telefone = frm.inTelefone.value
    const email = frm.inEmail.value
    const dataNasc = frm.inData.value
    resp.innerText = `Olá ${nome} 
             seu telefone é:${telefone} 
             e o email:${email}
             Sua data de nascimento é: ${dataNasc}`
    e.preventDefault()//evitar o envio do form.
})

//innerText
//innerHTML
//operadores aritméticos e lógicos
//if , for e vetores e matrizes
