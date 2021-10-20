import { createTheme } from '@mui/material/styles';

const theme = createTheme({
    spacing: 4,


    components: {
        // Name of the component
        MuiListItem: {
          styleOverrides: {
            // Name of the slot
            root: {
              // Some CSS
              fontSize: '1rem',
              border: 'lightblue solid 2px',
              borderRadius: '0.2em',
              margin: '1em',
              width: 'inherit',
            },
          },
        },

        // Name of the component
        MuiButton: {
          styleOverrides: {
            // Name of the slot
            root: {
              // Some CSS
              fontSize: '1rem',
            },
          },
        },
      },


});


export default theme;