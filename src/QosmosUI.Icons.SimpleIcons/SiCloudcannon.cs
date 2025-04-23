// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiCloudcannon : ComponentBase
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
		builder.AddAttribute(15, "d", "M20.686 7.602c.321-1.964-1.203-3.778-3.21-3.778-.91 0-1.733.376-2.325.977a1.132 1.132 0 0 0-1.061-.744c-.63 0-1.141.51-1.141 1.14s.429.909 1.34 1.335a5.884 5.884 0 0 1 .813.46c.275.184.534.388.776.612A6.02 6.02 0 0 1 17.796 12a6.02 6.02 0 0 1-2.694 5.008 6.16 6.16 0 0 1-.813.46c-.911.427-1.34.704-1.34 1.335 0 .63.51 1.141 1.14 1.141.492 0 .9-.312 1.062-.744.592.6 1.414.976 2.325.976 2.025 0 3.527-1.81 3.21-3.778C22.61 15.842 24 14.026 24 12.001c0-2.038-1.382-3.837-3.314-4.399zM9.711 17.468a6.193 6.193 0 0 1-1.589-1.073A6.02 6.02 0 0 1 6.204 12a6.02 6.02 0 0 1 1.918-4.395 6.22 6.22 0 0 1 1.589-1.072c.91-.427 1.34-.704 1.34-1.335s-.51-1.141-1.14-1.141c-.492 0-.9.312-1.062.744a3.257 3.257 0 0 0-2.325-.976c-2.003 0-3.536 1.807-3.21 3.778C1.381 8.164 0 9.962 0 12c0 2.028 1.38 3.836 3.314 4.397-.323 1.954 1.198 3.778 3.21 3.778.91 0 1.733-.375 2.325-.976.162.432.57.744 1.061.744.63 0 1.141-.51 1.141-1.14 0-.631-.429-.909-1.34-1.335zM12 8.443a3.557 3.557 0 1 1 0 7.114 3.557 3.557 0 0 1 0-7.114z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
