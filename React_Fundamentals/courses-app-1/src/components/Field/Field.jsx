import { Grid, Typography } from "@mui/material";

const Field = (props) => {
    return(
        <Grid container item xs={12} direction='row'>
            <Typography className='fieldName'>{props.name}:</Typography>
            <Typography className='fieldValue'>{props.value}</Typography>
        </Grid>
    )
};

export default Field;