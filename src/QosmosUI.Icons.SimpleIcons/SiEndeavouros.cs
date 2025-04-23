// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiEndeavouros : ComponentBase
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
		builder.AddAttribute(15, "d", "M14.03 2.036v.002C13.303 2.138 0 18.46 0 18.46s.957.272 3.135.588c0 0 10.435-17.061 10.904-17.008-.001 0-.01-.006-.01-.004zM3.135 19.048c-.95 1.562-1.71 2.818-1.71 2.818s10.218.46 18.165-.606c11.308-1.516-2.324-15.96-5.537-19.214 2.542 3.36 13.473 17.751 2.459 17.937-3.89.066-13.377-.935-13.377-.935zm10.906-17.01v.002c.022.01 0 .002 0-.002zm-.037.797c-.055.073-.09.112-.156.205a61.39 61.39 0 0 0-1.285 1.9 356.805 356.805 0 0 0-3.723 5.842c-2.448 3.908-4.467 7.208-4.846 7.826 1.034.107 8.948.935 12.508.875 1.322-.022 2.274-.26 2.926-.623.652-.363 1.022-.839 1.228-1.447.413-1.217.063-3.047-.753-5.018-1.537-3.711-4.485-7.686-5.899-9.56z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
