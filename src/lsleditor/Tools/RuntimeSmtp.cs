// <copyright file="gpl-2.0.txt">
// ORIGINAL CODE BASE IS Copyright (C) 2006-2010 by Alphons van der Heijden.
// The code was donated on 2010-04-28 by Alphons van der Heijden to Brandon 'Dimentox Travanti' Husbands &
// Malcolm J. Kudra, who in turn License under the GPLv2 in agreement with Alphons van der Heijden's wishes.
//
// The community would like to thank Alphons for all of his hard work, blood sweat and tears. Without his work
// the community would be stuck with crappy editors.
//
// The source code in this file ("Source Code") is provided by The LSLEditor Group to you under the terms of the GNU
// General Public License, version 2.0 ("GPL"), unless you have obtained a separate licensing agreement ("Other
// License"), formally executed by you and The LSLEditor Group.
// Terms of the GPL can be found in the gplv2.txt document.
//
// GPLv2 Header
// ************
// LSLEditor, a External editor for the LSL Language.
// Copyright (C) 2010 The LSLEditor Group.
//
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation; either version 2 of the License, or (at your option) any
// later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied
// warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more
// details.
//
// You should have received a copy of the GNU General Public License along with this program; if not, write to the Free
// Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// ********************************************************************************************************************
// The above copyright notice and this permission notice shall be included in copies or substantial portions of the
// Software.
// ********************************************************************************************************************
// </copyright>
//
// <summary>
//
//
// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LSLEditor.Tools
{
	public partial class RuntimeSmtp : UserControl, ICommit
	{
		public RuntimeSmtp()
		{
			this.InitializeComponent();

			this.EmailServer.Text = Properties.Settings.Default.EmailServer;
			this.EmailAddress.Text = Properties.Settings.Default.EmailAddress;

			this.SmtpUserid.Text = Properties.Settings.Default.SmtpUserid;
			this.SmtpPassword.Text = Properties.Settings.Default.SmtpPassword;

			switch (Properties.Settings.Default.SmtpAuth) {
				case "PLAIN":
					this.radioButton1.Checked = true;
					break;
				case "LOGIN":
					this.radioButton2.Checked = true;
					break;
				case "CRAM-MD5":
					this.radioButton3.Checked = true;
					break;
				case "DIGEST-MD5":
					this.radioButton4.Checked = true;
					break;
				case "EXTERNAL":
					this.radioButton5.Checked = true;
					break;
				case "ANONYMOUS":
					this.radioButton6.Checked = true;
					break;
				default:
					break;
			}
		}

		public void Commit()
		{
			Properties.Settings.Default.EmailServer = this.EmailServer.Text;
			Properties.Settings.Default.EmailAddress = this.EmailAddress.Text;

			Properties.Settings.Default.SmtpUserid = this.SmtpUserid.Text;
			Properties.Settings.Default.SmtpPassword = this.SmtpPassword.Text;

			if (this.radioButton1.Checked) {
				Properties.Settings.Default.SmtpAuth = "PLAIN";
			}

			if (this.radioButton2.Checked) {
				Properties.Settings.Default.SmtpAuth = "LOGIN";
			}

			if (this.radioButton3.Checked) {
				Properties.Settings.Default.SmtpAuth = "CRAM-MD5";
			}

			if (this.radioButton4.Checked) {
				Properties.Settings.Default.SmtpAuth = "DIGEST-MD5";
			}

			if (this.radioButton5.Checked) {
				Properties.Settings.Default.SmtpAuth = "EXTERNAL";
			}

			if (this.radioButton6.Checked) {
				Properties.Settings.Default.SmtpAuth = "ANONYMOUS";
			}
		}
	}
}
