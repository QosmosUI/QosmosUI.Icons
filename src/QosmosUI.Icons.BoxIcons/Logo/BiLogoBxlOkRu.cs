// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxlOkRu : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M11.986 12.341c-2.825 0-5.173-2.346-5.173-5.122C6.813 4.347 9.161 2 11.987 2c2.922 0 5.173 2.346 5.173 5.219a5.142 5.142 0 0 1-5.157 5.123l-.017-.001zm0-7.324c-1.196 0-2.106 1.005-2.106 2.203 0 1.196.91 2.106 2.107 2.106 1.245 0 2.107-.91 2.107-2.106.001-1.199-.862-2.203-2.108-2.203zm2.06 11.586 2.923 2.825c.575.621.575 1.531 0 2.106-.622.621-1.581.621-2.06 0l-2.922-2.873-2.826 2.873c-.287.287-.671.43-1.103.43-.335 0-.718-.144-1.054-.43-.575-.575-.575-1.485 0-2.107l2.97-2.825a13.49 13.49 0 0 1-3.063-1.339c-.719-.383-.862-1.34-.479-2.059.479-.718 1.341-.909 2.108-.43a6.62 6.62 0 0 0 6.897 0c.767-.479 1.676-.288 2.107.43.432.719.239 1.675-.432 2.059-.909.575-1.963 1.006-3.065 1.341l-.001-.001z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
