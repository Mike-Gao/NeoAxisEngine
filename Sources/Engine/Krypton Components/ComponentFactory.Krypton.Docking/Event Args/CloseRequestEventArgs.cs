﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2012. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 17/267 Nepean Hwy, 
//  Seaford, Vic 3198, Australia and are supplied subject to licence terms.
// 
//
// *****************************************************************************

using System;
using System.Drawing;
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;

namespace ComponentFactory.Krypton.Docking
{
	/// <summary>
    /// Event arguments for the PageCloseRequest event.
	/// </summary>
    public class CloseRequestEventArgs : UniqueNameEventArgs
	{
		#region Instance Fields
        private DockingCloseRequest _closeRequest;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the CloseRequestEventArgs class.
		/// </summary>
        /// <param name="uniqueName">Unique name of the page associated with the event.</param>
        /// <param name="closeRequest">Initial close action to use.</param>
        public CloseRequestEventArgs(string uniqueName, DockingCloseRequest closeRequest)
            : base(uniqueName)
		{
            _closeRequest = closeRequest;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets and sets the close action to be performed.
        /// </summary>
        public DockingCloseRequest CloseRequest
        {
            get { return _closeRequest; }
            set { _closeRequest = value; }
        }
        #endregion
	}
}
