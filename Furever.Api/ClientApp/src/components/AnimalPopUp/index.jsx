import React from 'react';
import './animalPopUp.css'

const AnimalPopUp = (props) => {
  
const animalData = {
  name: "Rex",
  desc: "I am a good boy looking for my furever home with a human who can match my enrgy level. I love long walks on the beach and snuggles with my hooman!"
}
const refuge =  {
  name: "SPCA de Montreal",
  address: '123 Decarie Est',
  postal: 'H3E 1V9'
}

  return (props.trigger) ? (
    <div className='AnimalPopUp'>
      <div className='AnimalPopUpInner'>
        <div className='PopUpHeader'>
          <h3>A little more about me</h3>
          <button className='close-btn' onClick={() => props.setTrigger(false)}>X button</button>
        </div>
        { props.children }
        <div className='RefugeInfo'>
          <h6>{animalData.name} currently await his furever home at:</h6>
          <div>{refuge.name}</div>
          <div>{refuge.address}</div>
          <div>{refuge.postal}</div>
        </div>
        <div className='AnimalPopImage'>IMAGE</div>
        <div className='AnimalDesc'>
          <h4>Hello my name is {animalData.name}</h4>
          <div>{animalData.desc}</div>
        </div>
        <div className='Buttons'>
          <button>Get more info about {animalData.name}</button>
          <button>Like Button</button>
        </div>
      </div>  
  </div>
  ) : "";
}

export default AnimalPopUp;