import React, { memo } from 'react'
import { setCurSongId } from '../actions/musicAction'
import { useDispatch } from 'react-redux'

 function SongItem(props) {
  const dispatch=useDispatch();
  const handelClickSongItem = (songId)=>{
    dispatch(setCurSongId(songId))
  }
  return (
    <div className='flex items-center rounded-xl px-2 py-2 gap-3 h-full w-full cursor-pointer hover:bg-teal-800 '
        onClick={()=>handelClickSongItem(props.songId)}
        >
        <img className='h-[60px] w-[60px] object-cover rounded-lg' src={props.thumbnail} alt="Imgae Song"/>
        <div>
            <h3 className='font-medium text-base text-slate-300 '>{props.title}</h3>
            <span className='text-slate-400'>{props.artist}</span>
        </div>
    </div>
  )
}
export default memo(SongItem)
