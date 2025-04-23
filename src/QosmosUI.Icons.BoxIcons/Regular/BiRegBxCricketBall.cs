// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxCricketBall : ComponentBase
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
		builder.AddAttribute(14, "d", "M19.07 4.93A10 10 0 0 0 4.93 19.07 10 10 0 0 0 19.07 4.93zM6.34 6.34a8 8 0 0 1 8.78-1.71l-.29.3.71.71.52-.53a9.53 9.53 0 0 1 .84.57L5.68 16.9a9.53 9.53 0 0 1-.57-.84l.53-.52-.71-.71-.29.29a8 8 0 0 1 1.7-8.78zm11.32 11.32a8 8 0 0 1-8.78 1.71l.29-.3-.71-.71-.52.53a9.53 9.53 0 0 1-.84-.57L18.32 7.1a9.53 9.53 0 0 1 .57.84l-.53.52.71.71.29-.29a8 8 0 0 1-1.7 8.78zm-6.37-2.12.71.7-1.41 1.42-.71-.66zm2.83-2.83.71.7-1.42 1.42-.7-.71zM17 9.88l.71.71L16.24 12l-.7-.71zm-4.29-1.42-.71-.7 1.41-1.42.71.71zm-2.83 2.83-.71-.7 1.42-1.42.7.71zm-2.83 2.83-.71-.71L7.76 12l.7.71z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
