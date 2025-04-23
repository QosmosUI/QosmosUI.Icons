// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiTorizon : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.63.349a.56.56 0 0 0-.304.09L8.719 2.132a.274.274 0 0 0 0 .457l2.607 1.693a.56.56 0 0 0 .607 0L14.54 2.59a.274.274 0 0 0 0-.457L11.933.439a.56.56 0 0 0-.303-.09M7.437 3.054a.56.56 0 0 0-.302.09L4.53 4.837a.274.274 0 0 0 0 .46L7.135 6.99a.56.56 0 0 0 .604 0l2.606-1.693a.274.274 0 0 0 0-.46L7.74 3.144a.56.56 0 0 0-.302-.09m8.852.316a.56.56 0 0 0-.302.09l-2.606 1.69a.274.274 0 0 0 0 .46l2.606 1.693a.56.56 0 0 0 .605 0l2.606-1.693a.274.274 0 0 0 0-.46l-2.606-1.69a.56.56 0 0 0-.303-.09M3.043 5.924a.56.56 0 0 0-.303.09L.134 7.707a.274.274 0 0 0 0 .46l2.606 1.69a.56.56 0 0 0 .605 0l2.606-1.69a.274.274 0 0 0 0-.46L3.345 6.014a.56.56 0 0 0-.302-.09m9.055.155a.56.56 0 0 0-.301.09l-2.6 1.689a.274.274 0 0 0 0 .46l2.6 1.693a.56.56 0 0 0 .603.003l2.607-1.692a.274.274 0 0 0 0-.46L12.4 6.167a.56.56 0 0 0-.302-.089m8.858.309a.56.56 0 0 0-.304.09L18.045 8.17a.274.274 0 0 0 0 .457l2.607 1.697a.56.56 0 0 0 .608 0l2.606-1.694a.274.274 0 0 0 0-.46L21.26 6.478a.56.56 0 0 0-.304-.09M7.702 8.945a.56.56 0 0 0-.303.09l-2.607 1.693a.274.274 0 0 0 0 .456L7.4 12.877a.56.56 0 0 0 .607 0l2.596-1.685a.274.274 0 0 0 0-.457l-2.596-1.7a.56.56 0 0 0-.304-.09m9.063.15a.56.56 0 0 0-.304.09l-2.606 1.694a.274.274 0 0 0 0 .457l2.606 1.692a.56.56 0 0 0 .608 0l2.606-1.692a.274.274 0 0 0 0-.457L17.07 9.186a.56.56 0 0 0-.304-.09M24 10.585a1.2 1.2 0 0 1-.351.611L12.973 18.13a1.83 1.83 0 0 1-1.992 0L.334 11.212a1.15 1.15 0 0 1-.333-.6v1.657a.74.74 0 0 0 .351.665l10.63 6.913a1.83 1.83 0 0 0 1.991 0l10.676-6.935a.74.74 0 0 0 .35-.643Zm-11.631 1.379a.56.56 0 0 0-.302.089L9.46 13.745a.274.274 0 0 0 0 .46l2.607 1.693a.56.56 0 0 0 .604 0l2.607-1.692a.274.274 0 0 0 0-.46l-2.607-1.694a.56.56 0 0 0-.302-.09m11.63 2.134a1.2 1.2 0 0 1-.35.607l-10.676 6.92a1.83 1.83 0 0 1-1.992 0L.334 14.722a1.15 1.15 0 0 1-.333-.597v1.654a.74.74 0 0 0 .351.66l10.63 6.917a1.83 1.83 0 0 0 1.991 0l10.676-6.934a.74.74 0 0 0 .35-.643z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
