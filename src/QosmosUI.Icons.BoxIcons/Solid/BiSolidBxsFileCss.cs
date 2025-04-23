// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Solid;

public class BiSolidBxsFileCss : ComponentBase
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
		builder.AddAttribute(14, "d", "M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8l-6-6zM9.446 17.412c.275 0 .581-.061.762-.132l.138.713c-.168.084-.546.174-1.037.174-1.397 0-2.117-.869-2.117-2.021C7.191 14.768 8.175 14 9.398 14c.474 0 .833.096.995.18l-.186.726a1.98 1.98 0 0 0-.768-.149c-.726 0-1.29.438-1.29 1.337.001.808.482 1.318 1.297 1.318zm2.491.755c-.461 0-.917-.119-1.145-.245l.186-.756c.246.126.624.252 1.014.252.42 0 .642-.174.642-.438 0-.252-.192-.396-.678-.57-.672-.234-1.109-.605-1.109-1.193 0-.689.575-1.217 1.529-1.217.455 0 .791.096 1.031.203l-.204.738a1.919 1.919 0 0 0-.846-.192c-.396 0-.587.181-.587.39 0 .258.228.372.749.57.714.264 1.05.636 1.05 1.205-.001.678-.523 1.253-1.632 1.253zm3.24 0c-.461 0-.917-.119-1.145-.245l.186-.756c.246.126.624.252 1.014.252.42 0 .642-.174.642-.438 0-.252-.192-.396-.678-.57-.672-.234-1.109-.605-1.109-1.193 0-.689.575-1.217 1.529-1.217.455 0 .791.096 1.031.203l-.204.738a1.919 1.919 0 0 0-.846-.192c-.396 0-.587.181-.587.39 0 .258.228.372.749.57.714.264 1.05.636 1.05 1.205 0 .678-.523 1.253-1.632 1.253zM14 9h-1V4l5 5h-4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
