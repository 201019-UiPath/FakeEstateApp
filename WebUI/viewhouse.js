function GetHouse()
{
    fetch('https://localhost:44341/House/GetHouse?houseId='+location.search.substring(1)) //fetch based on URL houseId
    .then(response => response.json())
    .then(result => {
        document.querySelector('#houseid').innerHTML = 'Viewing House with ID: '+result.houseId;
        document.querySelector('#bedrooms').innerHTML = 'Bedrooms: '+result.bedrooms;
        document.querySelector('#bathrooms').innerHTML = 'Bathrooms: '+result.bathrooms;
        document.querySelector('#floors').innerHTML = 'Floors: '+result.floors;
        document.querySelector('#location').innerHTML = 'Location: '+result.location;
        if (result.ac)
        {document.querySelector('#ac').innerHTML = 'AC: '+'Yes';}
        else {document.querySelector('#ac').innerHTML = 'AC: '+'No';}
        if (result.heating)
        {document.querySelector('#heating').innerHTML = 'Heating: '+'Yes';}
        else {document.querySelector('#heating').innerHTML = 'Heating: '+'No';}
        document.querySelector('#price').innerHTML = 'Price: $'+result.price.toLocaleString();

        document.querySelectorAll('#features li').forEach(element => element.remove()); //clear unordered list
        let listElement = document.querySelector('#features'); //gets unordered list
        let features = result.features;
        if (features!=null)
        {
            console.log("iterating through features with length="+features.length);
            for (let i=0; i<features.length; i++) 
            {
                let li = document.createElement('li');
                li.innerHTML = features[i].description;
                listElement.appendChild(li);
            }
        }
        else
        {

        }
    });
}