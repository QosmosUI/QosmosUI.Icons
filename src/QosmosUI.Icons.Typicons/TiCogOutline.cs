// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiCogOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M13 5l.855 3.42 3.389-.971 1.501 2.6-2.535 2.449 2.535 2.451-1.5 2.6-3.39-.971-.855 3.422h-3l-.855-3.422-3.39.971-1.501-2.6 2.535-2.451-2.534-2.449 1.5-2.6 3.39.971.855-3.42h3m0-2h-3c-.918 0-1.718.625-1.939 1.516l-.354 1.412-1.4-.4c-.184-.053-.369-.078-.552-.078-.7 0-1.368.37-1.731 1l-1.5 2.6c-.459.796-.317 1.802.342 2.438l1.047 1.011-1.048 1.015c-.66.637-.802 1.643-.343 2.438l1.502 2.6c.363.631 1.031 1 1.731 1 .183 0 .368-.025.552-.076l1.399-.401.354 1.415c.222.885 1.022 1.51 1.94 1.51h3c.918 0 1.718-.625 1.939-1.516l.354-1.414 1.399.4c.184.053.369.077.552.077.7 0 1.368-.37 1.731-1l1.5-2.6c.459-.796.317-1.8-.342-2.438l-1.047-1.013 1.047-1.013c.66-.637.801-1.644.342-2.438l-1.5-2.6c-.365-.631-1.031-1-1.732-1-.184 0-.368.025-.551.076l-1.4.401-.354-1.413c-.22-.884-1.02-1.509-1.938-1.509zM11.5 10.5c1.104 0 2 .895 2 2 0 1.104-.896 2-2 2s-2-.896-2-2c0-1.105.896-2 2-2m0-1c-1.654 0-3 1.346-3 3s1.346 3 3 3 3-1.346 3-3-1.346-3-3-3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
