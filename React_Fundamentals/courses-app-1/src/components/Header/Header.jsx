import {  Stack, Typography } from "@mui/material";
import Logo from '../Logo/Logo';
import MyButton from '../Button/Button';

const Header = (props) => {
    return(
        <Stack direction="row" className='header'>
            <Logo />
            <Stack direction="row" className='right'>
                <Typography >{props.individuumName}</Typography>
                <MyButton>Logout</MyButton>
            </Stack>
        </Stack>
    );
};

export default Header;