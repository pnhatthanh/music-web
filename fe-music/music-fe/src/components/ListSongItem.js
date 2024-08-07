import React from "react";
import moment from 'moment'
import { setCurSongId } from '../actions/musicAction'
import { useDispatch } from 'react-redux'
export default function ListSongItem(props) {
  const dispatch=useDispatch();
  const handelClickSongItem = (songId)=>{
    dispatch(setCurSongId(songId))
  }
  return (
    <div className="flex justify-between gap-2 text-base py-1 text-slate-100 my-1 rounded-xl transition-all hover:bg-teal-900 cursor-pointer"
      onClick={()=>handelClickSongItem(props.songId)}>
      <div className="h-[60px] w-1/2 flex items-center rounded-xl px-2 py-2 gap-3">
          <img className="h-[60px] w-[60px] object-cover rounded-lg" src={props.thumbnail} alt="Imgae Song"/>
          <div>
            <h3 className="font-medium text-base text-slate-300 ">{props.title}</h3>
            <span className="text-slate-400">{props.artist}</span>
          </div>
      </div>
      <span className="w-1/3 flex items-center">{props.listenCount.toLocaleString('en-US')}</span>
      <span className="w-1/5 flex justify-center items-center">{moment.utc(props.duration*1000).format('mm:ss')}</span>
    </div>
  );
}
