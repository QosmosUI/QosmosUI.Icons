// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiSidequest : ComponentBase
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
		builder.AddAttribute(15, "d", "M24 10.409 18.689 1.21H8.065l2.518 4.359.769 1.331-.918 1.592H8.598l-.769-1.333-2.517-4.36L0 11.999l5.311 9.199 2.518-4.36.769-1.333h1.836l.919 1.593-.77 1.332-2.517 4.359H18.69L24 13.59h-6.571l-.919-1.591.919-1.59H24ZM5.288 5.328 6.27 7.03 4.763 9.64h6.334l3.169-5.486h-3.015l-.983-1.702h7.046l-5.183 8.977H1.763l3.525-6.101Zm4.98 16.219.983-1.703h3.015l-3.169-5.488H4.763l1.507 2.611-.982 1.704-3.525-6.104h10.368l1.364 2.363 3.819 6.617h-7.046Zm8.084-4.062 1.505-2.61h1.969l-3.525 6.102-3.109-5.382-2.077-3.596 2.459-4.257 2.727-4.72 3.525 6.102h-1.969l-1.505-2.611-3.17 5.486 3.17 5.486Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
