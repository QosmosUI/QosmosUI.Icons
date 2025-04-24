// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiKofax : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M1.38 12.94l.576-.5 1.273 1.698h1.835l-2.001-2.593 1.85-1.683h-1.82L1.38 11.545V9.862H0v4.276h1.38z M7.353 9.726c-1.455 0-2.683.5-2.683 2.274s1.228 2.274 2.683 2.274 2.684-.5 2.684-2.274-1.228-2.274-2.684-2.274zm0 3.593c-.728 0-1.228-.41-1.228-1.319 0-.894.5-1.319 1.228-1.319.743 0 1.228.425 1.228 1.32 0 .894-.5 1.318-1.228 1.318zM11.795 14.138v-1.653h2.365v-.925h-2.365v-.742h2.547v-.956h-3.926v4.276zM22.21 11.91l1.593-2.063h-1.638L21.407 11l-.758-1.153h-1.637l1.592 2.062-1.607 2.001-1.668-4.048h-1.683l-1.759 4.276h1.471l.243-.698h1.804l.242.698h2.896l.88-1.289.879 1.289H24zm-6.276.651l.576-1.622h.015l.577 1.622z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
