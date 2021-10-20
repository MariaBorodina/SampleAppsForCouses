import { Button } from "@mui/material";

const MyButton = (props) => {
    return(
        <Button {...props}>{props.children}
        </Button>
    );
};

export default MyButton;