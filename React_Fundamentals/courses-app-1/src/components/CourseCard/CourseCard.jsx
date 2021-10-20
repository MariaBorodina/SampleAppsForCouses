import { ListItem, ListItemText } from "@mui/material";

const CourseCard = (props) => {
    return (
    <ListItem>
        <ListItemText>{props.title}</ListItemText>
    </ListItem>
    )
}

export default CourseCard;
