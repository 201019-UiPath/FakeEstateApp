
function AddHouse()
{
    let house = {};
    house.bedrooms = parseInt( document.querySelector('#bedrooms').value);
    house.bathrooms = parseInt(document.querySelector('#bathrooms').value);
    house.floors = parseInt(document.querySelector('#floors').value);
    house.location = document.querySelector('#location').value;
    house.ac = document.querySelector('#ac').checked;
    house.heating =document.querySelector('#heating').checked;
    house.price = parseInt(document.querySelector('#price').value);

    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function(){
        if(this.readyState == 4 && this.status > 199 && this.status < 300)
        {
            alert("New house added!");
            document.querySelector('#bedrooms').value = '';
            document.querySelector('#bathrooms').value= '';
            document.querySelector('#floors').value= '';
            document.querySelector('#location').value= '';
            document.querySelector('#ac').prop( "checked", false );
            document.querySelector('#heating').prop( "checked", false );
            document.querySelector('#price').value= '';
        }
    };
    xhr.open("POST", 'https://localhost:44341/House/AddHouse', true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(house));
}

