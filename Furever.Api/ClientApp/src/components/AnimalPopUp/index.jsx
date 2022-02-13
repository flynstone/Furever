import React from 'react';
import './animalPopUp.css'

const AnimalPopUp = ({animals, setSelectedAnimal}) => {
  
const animal = {
  name: "Rex",
  desc: "I am a good boy looking for my furever home with a human who can match my enrgy level. I love long walks on the beach and snuggles with my hooman!"
}
const refuge =  {
  name: "SPCA de Montreal",
  address: '123 Decarie Est',
  postal: 'H3E 1V9'
}

  return (
    <div className='AnimalPopUp'>
      <div className='PopUpHeader'>
        <h3>A little more about me</h3>
        <button onClick={() => setSelectedAnimal(null)}>X button</button>
      </div>
      <div className='RefugeInfo'>
        <h6>{animal.name} currently await his furever home at:</h6>
        <div>{refuge.name}</div>
        <div>{refuge.address}</div>
        <div>{refuge.postal}</div>
      </div>
      <div className='AnimalImage'>IMAGE</div>
      <div className='AnimalDesc'>
        <h4>Hello my name is {animal.name}</h4>
        <div>{animal.desc}</div>
      </div>
      <div className='Buttons'>
        <button>Get more info about {animal.name}</button>
        <button>Like Button</button>
      </div>
    </div>
  ) 
  // Once animal is clicked, the pop up fills the page and displays more info as well as the liked component and the ask more info button
}

export default AnimalPopUp;