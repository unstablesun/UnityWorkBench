using System;
using System.Collections.Generic;
using UnityEngine.Assertions;
/*
namespace Gemini
{
	public class UIStack
	{
		#region public
		[Flags]
		public enum Transition
		{
			None = 0,
			Intro = 1,
			Outro = 2,
			Full = Intro | Outro
		}

		public UIStack()
		{
			m_stack = new Stack<IUIPanel>();
		}

		public int Count
		{
			get { return m_stack.Count; }
		}

		public void Push( IUIPanel panel )
		{
			Push( panel, Transition.Full );
		}

		public void Push( IUIPanel panel, Transition transition )
		{
			Assert.IsNotNull( panel, "UIStack.Push: panel is null" );

			// hide top
			if ( Count > 0 )
			{
				IUIPanel curPanel = Peek();
				curPanel.Active = false;
				curPanel.OnHide( BitField.IsFlagSet( transition, Transition.Outro ) );
			}

			// push new
			m_stack.Push( panel );
			panel.Active = true;
			panel.OnPush( BitField.IsFlagSet( transition, Transition.Intro ) );
		}

		public IUIPanel Pop()
		{
			return Pop( Transition.Full );
		}

		public IUIPanel Pop( Transition transition )
		{
			// pop top
			IUIPanel poppedPanel = m_stack.Pop();
			Assert.IsNotNull( poppedPanel, "UIStack.Pop: Top panel is null" );
			poppedPanel.Active = false;
			poppedPanel.OnPop( BitField.IsFlagSet( transition, Transition.Outro ) );

			// show prev
			if ( Count > 0 )
			{
				IUIPanel newTop = Peek();
				Assert.IsNotNull( poppedPanel, "UIStack.Pop: New top panel is null" );
				newTop.Active = true;
				newTop.OnShow( BitField.IsFlagSet( transition, Transition.Intro ) );
			}

			return poppedPanel;
		}

		public void Clear()
		{
			m_stack.Clear();
		}

		public IUIPanel Peek()
		{
			Assert.IsTrue( Count > 0, "UIStack.Peek: The stack is empty" );
			return m_stack.Peek();
		}

		public bool Contains( IUIPanel panel )
		{
			return m_stack.Contains( panel );
		}
		#endregion // public

		#region private
		private Stack<IUIPanel> m_stack;
		#endregion // private
	}
}
*/