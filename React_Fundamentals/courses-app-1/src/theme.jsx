import { createTheme } from '@mui/material/styles';

const theme = createTheme({
    spacing: 4,


    components: {


        // Name of the component
        MuiStack: {
          styleOverrides: {
            // Name of the slot
            root: {
              display: 'flex',

              '&.header': {              
                // Some CSS
                fontSize: '1rem',
                border: '#ff2200 solid 1px',
                borderRadius: '0.2em',
                margin: '1em',
                width: 'inherit',
                padding: '1em',
                justifyContent: 'space-between',
                alignItems: 'center',

              },

              '&.right': {
                display: 'flex',
                justifyContent: 'flex-end',
                float: 'right',
                alignItems: 'center',
              },

            },
          },
        },


        // Name of the component
        MuiList: {
          styleOverrides: {
            // Name of the slot
            root: {
              // Some CSS
              fontSize: '1rem',
              border: 'lightblue solid 1px',
              borderRadius: '0.2em',
              margin: '1em',
              width: 'inherit',
            },
          },
        },

        // Name of the component
        MuiListItem: {
          styleOverrides: {
            // Name of the slot
            root: {
              // Some CSS
              fontSize: '1rem',
              border: '#00aa55 solid 1px',
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
              fontSize: '0.8em',
              textTransform: 'none',
              padding: '0 0.8em',
              margin: '0 0.5em',
              border: '#cc00ee solid 1px',
              color: 'black',
              alignSelf: 'center',
              width: 'fit-content',
            },
          },
        },

        MuiTypography: {
          styleOverrides: {
            root:{
              fontSize: '0.8em',

              '&.fieldName': {
                fontWeight: '600',
                paddingRight: '0.5em',
              },
            },

            h2: {
              fontSize: '1.2em',
              fontWeight: '600',
            },
          }
        }
      },


});


export default theme;