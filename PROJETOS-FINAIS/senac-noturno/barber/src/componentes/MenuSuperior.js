const MenuSuperior = ()=>{
   return(

        <nav className="navbar navbar-expand-sm bg-primary navabar-dark sticky-top">
             
             <div className="container">
                 <a className="navbar-brand" href="#">Cadastro de Clientes</a>
                 <ul className="navbar-nav">

                     <li className="nav-item">
                          <a className="nav-link" href="#">Inclusão</a>                          
                     </li>
                     <li className="nav-item">
                          <a className="nav-link" href="#">Manutenção</a>                          
                     </li>
                     <li className="nav-item">
                          <a className="nav-link" href="#">Resumo</a>                          
                     </li>

                 </ul>

             </div>
        </nav>   
   );

};
export default MenuSuperior;