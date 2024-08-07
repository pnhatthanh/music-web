import React from 'react'
import { IoNotifications } from "react-icons/io5";
import { IoChevronBack } from "react-icons/io5";
import { IoChevronForwardSharp } from "react-icons/io5";
import Search from './Search';

export default function Header() {
  return (
    <div className='h-[70px] flex py-[14px] justify-between items-center'>
        <div className='flex text-slate-800 gap-2'>
            <span className='p-1 rounded-full  bg-teal-700'><IoChevronBack size={24}/></span>
            <span className='p-1 rounded-full  bg-teal-700'><IoChevronForwardSharp size={24}/></span>
        </div>
        <Search />
        <div className='flex text-amber-100 gap-3 items-center'>
            <IoNotifications size={24}/>
            <div className='w-10 h-10 rounded-full overflow-hidden'>
              <img className='w-full h-full object-cover' src='https://gcs.tripi.vn/public-tripi/tripi-feed/img/474088uQO/hinh-anh-nhung-con-cho-de-thuong_092948873.jpg' alt='User' />
            </div>
        </div>
    </div>
  )
}
