// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoListOrdered : ComponentBase
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
		builder.AddAttribute(14, "d", "M3.604 3.089A.75.75 0 0 1 4 3.75V8.5h.75a.75.75 0 0 1 0 1.5h-3a.75.75 0 1 1 0-1.5h.75V5.151l-.334.223a.75.75 0 0 1-.832-1.248l1.5-1a.75.75 0 0 1 .77-.037ZM8.75 5.5a.75.75 0 0 0 0 1.5h11.5a.75.75 0 0 0 0-1.5H8.75Zm0 6a.75.75 0 0 0 0 1.5h11.5a.75.75 0 0 0 0-1.5H8.75Zm0 6a.75.75 0 0 0 0 1.5h11.5a.75.75 0 0 0 0-1.5H8.75ZM5.5 15.75c0-.704-.271-1.286-.72-1.686a2.302 2.302 0 0 0-1.53-.564c-.535 0-1.094.178-1.53.565-.449.399-.72.982-.72 1.685a.75.75 0 0 0 1.5 0c0-.296.104-.464.217-.564A.805.805 0 0 1 3.25 15c.215 0 .406.072.533.185.113.101.217.268.217.565 0 .332-.069.48-.21.657-.092.113-.216.24-.403.419l-.147.14c-.152.144-.33.313-.52.504l-1.5 1.5a.75.75 0 0 0-.22.53v.25c0 .414.336.75.75.75H5A.75.75 0 0 0 5 19H3.31l.47-.47c.176-.176.333-.324.48-.465l.165-.156a5.98 5.98 0 0 0 .536-.566c.358-.447.539-.925.539-1.593Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
